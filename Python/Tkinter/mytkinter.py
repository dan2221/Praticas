from tkinter import *
from PIL import ImageTk,Image

clear = lambda: os.system('cls')

root = Tk()

echo = lambda value: Label(root, text=value).pack()

# Adjust size 
root.geometry("400x400")

#root.title('SorR Mod Manager')
#root.iconbitmap('icons/2.ico')
bg = PhotoImage(file = "Your_img.jpg")

# Create Canvas
canvas1 = Canvas( root, width = 400, height = 400)

# Display image
canvas1.create_image( 0, 0, image = bg, anchor = "nw")

texto1 = Label(root, text='Meu texto1')

#Label(root, text="   SorR Mod Manager   \nChoose a Mod to install:").pack()
#echo('Este é meu texto via função lambda!')
#echo('Este é meu texto via função lambda!')
#echo('Este é meu texto via função lambda!')
texto1.grid(row=0, column=0)


#button_quit = Button(root, text="Exit Program", command=root.quit)
#button_quit.pack()

root.mainloop()