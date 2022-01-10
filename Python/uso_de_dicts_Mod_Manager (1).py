# Mod's Dict (Key is the ID and Value the Mod Name)
mods = {1: 'Brutal Justice v1.0',
        2: 'DOA',
        3: 'Nightsweeper v1.4',
        4: 'Never Back Down',
        5: 'Rage Rise of The Black Dragon',
        6: 'SoR3 - Adams Story Extended',
        7: 'Streets of Rage V - demo 2017',
        8: 'Urban Reign',
        9: 'Way of the Warrior',
        10: 'Streets Of Kamurocho',
        11: 'Quem me perguntar sobre progresso de sprite é arrombado'}
#     Keys  |  Values

# Searching for Mods

# Listing all mod names: -- values()
#for value in mods.values():
#    print(value)

# Listing all IDs: -- keys()
for key in mods.keys():
    print(key)
print('-------------------------------')
print('-------------------------------')
print(f'Contagem: {len(mods.keys())}')
print('-------------------------------')
print('-------------------------------')
# Listing all IDs:  -- .items()
for key, value in mods.items():
    print(f'{key} - {value}')

# Searching for the desired mod
print(mods[1])
# -- Brutal Justice v1.0

# Searching for the ID of a mod
for key, value in mods.items():
    if value == 'DOA':
        print(key)
# -- 2
#newdict = {}

#newdict.update({1: {'título': 'BurningFight Remake', 'variável': 'bfr2021'}})
#newdict.update({2: {'título': 'BurningFight Remake', 'variável': 'bfr2021'}})
#newdict.update({3: {'título': 'BurningFight Remake', 'variável': 'bfr2021'}})

#print(newdict)
# Add a mod
mods.update({12: {'título': 'BurningFight Remake', 'variável': 'bfr2021', 'IDnum': 22}})
mods[12].update({'IDnum': 22})
print(mods[12]['IDnum'])
print('Lista completa: ')
for value in mods.values():
    print(value)

# Remove a mod
mods.pop(11, None)

for value in mods.values():
    print(value)

print('---------------------------')
print(mods[12])
print('---------------------------')
