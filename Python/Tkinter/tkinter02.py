from tkinter import *
root = Tk()

# FRAME: Funciona comom um container, ele agrupa e organiza outros widgets.
myContainer1 = Frame(root)

# PACK: 
myContainer1.pack()
button1 = Button(myContainer1) ### (1)
button1["text"]= "Hello, World!" ### (2)
button1["background"] = "green" ### (3)
button1.pack() ### (4)
root.mainloop()
