from PIL import Image
with Image.open("example.png") as im:
    im.rotate(45).show()