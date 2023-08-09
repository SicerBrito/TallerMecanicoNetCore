from flask import Flask
from flask_restplus import Api
from dotenv import load_dotenv
import os

app = Flask(__name__)
load_dotenv()

# Configuración de Flask y otros módulos aquí

# Configuración de la API con Flask-RESTPlus
api = Api(app, title="Password Reset API", description="API for password reset")

# Importar y configurar módulos de la API aquí
from resources import PasswordResetResource, PasswordChangeResource
api.add_resource(PasswordResetResource, '/reset_password')
api.add_resource(PasswordChangeResource, '/change_password')

if __name__ == "__main__":
    app.run(debug=True)
