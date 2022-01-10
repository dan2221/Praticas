import tkinter as tk
from tkinter import ttk

# create the root window
root = tk.Tk()

root.title('Label Widget Image')

# display an image label
photo = tk.PhotoImage(file='python2.png')
image_label = ttk.Label(
    root,
    image=photo,
    padding=5
)
image_label.pack()

root.mainloop()
