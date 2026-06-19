pipeline {
    agent any

    stages {

        stage('Clonar Repositorio') {
            steps {
                echo 'Clonando repositorio desde GitHub...'
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                echo 'Restaurando dependencias...'
                bat 'dotnet restore ProyectoJenkins.slnx'
            }
        }

        stage('Build') {
            steps {
                echo 'Compilando la solución...'
                bat 'dotnet build ProyectoJenkins.slnx --no-restore --configuration Release'
            }
        }

        stage('Test') {
            steps {
                echo 'Ejecutando pruebas unitarias...'
                bat 'dotnet test ProyectoJenkins.slnx --no-build --configuration Release --verbosity normal'
            }
        }

        stage('Publish') {
            steps {
                echo 'Publicando la aplicación...'
                bat 'dotnet publish mi-proyecto/mi-proyecto.csproj --no-build --configuration Release --output ./publish'
            }
        }

    }

    post {
        success { echo 'Pipeline completado exitosamente.' }
        failure { echo 'El pipeline falló. Revisar los logs.' }
    }
}