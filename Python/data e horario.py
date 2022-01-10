from datetime import date, time, datetime, timedelta

data_atual = date.today()
tempo_atual = datetime.now()
print('Data de hoje: ',data_atual)
print('Data no nosso padrão: ',data_atual.strftime('%d/%m/%y'))
print('Ano com mais dígitos: ',data_atual.strftime('%d/%m/%Y'))
print('Nomes do dia e mês: ',data_atual.strftime('%A %B %Y'))

print('\nAntes da conversão:',type(data_atual))

data_atual_str = data_atual.strftime('%A %B %Y')

print('Depois da conversão:',type(data_atual_str),'\n')
print('Data e horário atual:',datetime.now())
print('Apenas o ano: ',data_atual.year)
print('Apenas o mês: ',data_atual.month)
print('Apenas o dia da semana: ',tempo_atual.weekday())
print('Apenas o dia: ',data_atual.day)
print('Apenas a hora: ',tempo_atual.hour)
print('Apenas o minuto: ',tempo_atual.minute)
print('Apenas o segundo: ',tempo_atual.second)

# Traduzir data para português
tupla = ('Segunda','Terça','Quarta','Quinta','Sexta','Sábado','Domingo')
print('Dia da semana traduzido: ',tupla[data_atual.weekday()])

tempo = time(hour=15, minute=18, second=30)
print('\nHorário definido: ',tempo)

data_criada = datetime(2018, 6, 20, 15, 30, 20)
print(data_criada)
print(data_criada.strftime('%c'))

data_string = '01/01/2019 12:20:22'
# Conversão de tipo string para datetime
data_convertida = datetime.strptime(data_string, '%d/%m/%Y %H:%M:%S')
print(data_convertida)

# Subtração de tempo
nova_data = data_convertida - timedelta(days=365, hours=2, minutes=15)
print('Subtração de data/tempo:',nova_data)