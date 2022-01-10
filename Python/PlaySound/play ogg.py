# Algotithm found here: https://www.codegrepper.com/code-examples/python/play+.ogg+files+with+python
# Credits to Flyhouse_Squarewheel

# This program uses the Pyglet module by Alex Holkner.
# More information here: https://pypi.org/project/pyglet/
# Pyglet is under the BSD open-source license.
###############################################################################################################
import pyglet				# Imports the module
pyglet.options['search_local_libs'] = True	# Allows pyglet to access files in your directory

my_music = pyglet.media.load("1.ogg")	# Loads the audio file you want to play (it does not have to be a .ogg)

my_player = pyglet.media.Player()	# Creates a player

my_player.queue(my_music)	# Adds your song to the players queue
my_player.loop = True 		# If you want the player to loop your song. By default this value is False
my_player.play()			# Starts playing your audio file when you run the app

pyglet.app.run()			# Runs the app