from flask import Flask
from flask_mail import Mail
from flask_restplus import Api
from itsdangerous import URLSafeTimedSerializer
from flask_sqlalchemy import SQLAlchemy
from passlib.hash import sha256_crypt
from dotenv import load_dotenv
import os

app = Flask(__name__)
load_dotenv()

# Configuración de Flask-Mail
app.config['MAIL_SERVER'] = os.getenv('MAIL_SERVER')
app.config['MAIL_PORT'] = int(os.getenv('MAIL_PORT'))
app.config['MAIL_USE_TLS'] = os.getenv('MAIL_USE_TLS') == 'True'
app.config['MAIL_USERNAME'] = os.getenv('MAIL_USERNAME')
app.config['MAIL_PASSWORD'] = os.getenv('MAIL_PASSWORD')
mail = Mail(app)

# Configuración de la clave secreta para el serializer
app.config['SECRET_KEY'] = os.getenv('SECRET_KEY')
serializer = URLSafeTimedSerializer(app.config['SECRET_KEY'])

# Configuración de la base de datos SQLAlchemy con MySQL
app.config['SQLALCHEMY_DATABASE_URI'] = os.getenv('SQLALCHEMY_DATABASE_URI')
db = SQLAlchemy(app)

# Modelo de Usuario
class User(db.Model):
    email = db.Column(db.String(120), primary_key=True)
    name = db.Column(db.String(80))
    password = db.Column(db.String(120))
    token = db.Column(db.String(120))

# Configuración de la API con Flask-RESTPlus
api = Api(app, title="Password Reset API", description="API for password reset")

# Importar y configurar módulos de la API aquí

if __name__ == "__main__":
    app.run(debug=True)
