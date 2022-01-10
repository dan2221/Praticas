''' Requests

GET: Pede um recurso ao servidor.
HEAD: Obtém somente o cabeçãlho do recurso (metadados).
POST: Envia dados para o servidor processar (criar novo recurso).
PUT: Cria ou edita algum recurso.
DELETE: Solicita a remoção de um recurso.

'''
import requests

try:
	requisicao = requests.get('https://solyd.com.br')
except Exception as e:
	print('Requisição deu erro:', e)


print(requisicao.status_code) # Código de retorno
#print(requisicao.text) # Código HTML

url = 'https://digitalinnovation.one'
response = requests.get(url)
status_code = response.status_code

print(response)