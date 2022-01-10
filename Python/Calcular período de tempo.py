# Algorítimo para somar um período de tempo (min) a outro (horas e minutos).

hour = int(input("Starting time (hours): "))
mins = int(input("Starting time (minutes): "))
dura = int(input("Event duration (minutes): "))

# Write your code here.

calc1=int(((hour * 60 + mins + dura)/60))
calc2=((hour * 60 + mins + dura)%60)

while calc1 >= 24:
    calc1 -= 24
    
while calc2 >= 60:
    calc1 -= 60
    
print(calc1,':',calc2,sep='')