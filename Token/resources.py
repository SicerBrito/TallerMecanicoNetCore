from flask_restplus import Resource, reqparse
from flask_mail import Message
from itsdangerous import URLSafeTimedSerializer
from passlib.hash import sha256_crypt
from app import db, mail, serializer
from models import User

# Recurso para manejar el proceso de restablecimiento de contraseña
class PasswordResetResource(Resource):
    def post(self):
        parser = reqparse.RequestParser()
        parser.add_argument('email', required=True, help="Email is required.")
        args = parser.parse_args()

        email = args['email']
        user = User.query.filter_by(email=email).first()

        if user:
            token = serializer.dumps(email, salt='password-reset')
            user.token = token
            db.session.commit()

            reset_link = f"http://yourwebsite.com/reset_password?token={token}"
            message = f"Hello {user.name},\n\nTo reset your password, please click on the following link:\n{reset_link}"
            msg = Message(subject="Password Reset", recipients=[email], body=message)
            mail.send(msg)

            return {"message": "Password reset link sent to your email."}, 200
        else:
            return {"error": "User not found."}, 404

# Recurso para manejar el proceso de cambio de contraseña
class PasswordChangeResource(Resource):
    def post(self):
        parser = reqparse.RequestParser()
        parser.add_argument('token', required=True, help="Token is required.")
        parser.add_argument('password', required=True, help="Password is required.")
        args = parser.parse_args()

        token = args['token']
        password = args['password']

        try:
            email = serializer.loads(token, salt='password-reset', max_age=3600)
            user = User.query.filter_by(email=email, token=token).first()

            if user:
                user.password = sha256_crypt.encrypt(password)  # Encripta la contraseña
                user.token = None
                db.session.commit()
                return {"message": "Password reset successful."}, 200
            else:
                return {"error": "Invalid or expired token."}, 400
        except:
            return {"error": "Invalid or expired token."}, 400
