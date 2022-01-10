import tkinter as tk
from random import shuffle

participants = [
    "Iori Yagami", "Kyo Kusanagi", "Rugal Bernstain", "Leopold Goenitz"
]

def get_pairings():
    '''for simulation purposes, this simply randomizes the participants'''
    global participants

    # see http://stackoverflow.com/a/23286332/7432
    shuffle(participants)
    return zip(*[iter(participants)]*2)


def reset():
    '''Reset the list of participants'''
    for child in app.winfo_children():
        child.destroy()

    for players in get_pairings():
        label = tk.Label(app, text="%s vs. %s" % players)
        label.grid()

root = tk.Tk()

root.title("Tournament")

app = tk.Frame(root)
app.grid()

button=tk.Button(root,text="Next Round", command=reset)
button.grid()

# this sets up the first round

reset()

root.mainloop()