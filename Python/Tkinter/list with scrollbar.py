import tkinter
from tkinter import *
from tkinter import messagebox

def datafetch():
	x = lbx.get(ACTIVE)
	messagebox.showinfo("data","Você selecionou "+x)

root = tkinter.Tk()
root.geometry("400x400")

fr = Frame(root)
fr.pack()

sbr = Scrollbar(
	fr,
)
sbr.pack(side=RIGHT, fill="y")

lbx = Listbox(
	fr,
	font = ("Verdana",16),
)

lbx.pack(side=LEFT, fill="both",expand=True)

for data in range(50):
	lbx.insert(data, "Dado de amostra "+str(data+1))

sbr.config(command=lbx.yview)
lbx.config(yscrollcommand=sbr.set)

btn = Button(
	root,
	text = "Select",
	font = ("Verdana",16),
	command = datafetch,
)
btn.pack()

root.mainloop()