pipeline {
    agent any
    stages {
        stage('Restore') {
            steps { bat 'dotnet restore ProyectoJenkins.slnx' }
        }
        stage('Build') {
            steps { bat 'dotnet build ProyectoJenkins.slnx --no-restore' }
        }
        stage('Test') {
            steps { bat 'dotnet test ProyectoJenkins.slnx --no-build' }
        }
    }
}