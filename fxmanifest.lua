fx_version 'cerulean'
game 'gta5'

files {
	'Client/*.dll'
}

client_scripts {
	'Client/*.net.dll'
}
server_scripts {
	'Server/bin/Release/**/publish/*.net.dll'
}

name 'ServerSync'
author 'Wyste (original) & BBrown (Dotnet Port)'
version '1.0.0'
description 'Synchronizes Time/Weather/Wind and more.'
url 'https://github.com/BBrown4/ServerSync'