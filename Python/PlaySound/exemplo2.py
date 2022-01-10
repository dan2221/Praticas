from pygame import mixer

def play_music():
    """
        Function to play music during the tool use
        Credits: Yuzo Koshiro
    """
    mixer.init()
    mixer.music.load('Walking_In_The_sun.mp3')
    mixer.music.play()

play_music()