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
                sh 'dotnet restore ProyectoJenkins.slnx'
            }
        }

        stage('Build') {
            steps {
                echo 'Compilando la solución...'
                sh 'dotnet build ProyectoJenkins.slnx --no-restore --configuration Release'
            }
        }

        stage('Test') {
            steps {
                echo 'Ejecutando pruebas unitarias...'
                sh 'dotnet test ProyectoJenkins.slnx --no-build --configuration Release --verbosity normal'
            }
        }

        stage('Publish') {
            steps {
                echo 'Publicando la aplicación...'
                sh 'dotnet publish mi-proyecto/mi-proyecto.csproj --no-build --configuration Release --output ./publish'
            }
        }

    }

    post {
        success { echo 'Pipeline completado exitosamente.' }
        failure { echo 'El pipeline falló. Revisar los logs.' }
    }
}