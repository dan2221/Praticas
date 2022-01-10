IF EXIST "mod\games\Brutal Justice v1.0\palettes\enemies"	(set s_brutal=0) ELSE (
	IF EXIST "mod\brutal.txt"				(set s_brutal=1) ELSE (set s_brutal=2)
)

IF EXIST "mod\games\H.U.N.T.E.R MotY\data" (
	IF EXIST "mod\games\H.U.N.T.E.R MotY\palettes\enemies"		(set s_hunter=0) ELSE (
		IF EXIST "mod\hunter.txt"				(set s_hunter=1) ELSE (set s_hunter=2)
	)
) ELSE (set s_hunter=2)

IF EXIST "mod\games\Battle for Rio\data" (
	IF EXIST "mod\games\Battle for Rio\palettes\enemies"		(set s_bfr=0) ELSE (
		IF EXIST "mod\bfr.txt"					(set s_bfr=1) ELSE (set s_bfr=2)
	)
) ELSE (set s_bfr=2)

IF EXIST "mod\games\Battle for Rio 2\data" (
	IF EXIST "mod\games\Battle for Rio 2\palettes\enemies"		(set s_bfr2=0) ELSE (
		IF EXIST "mod\bfr2.txt"					(set s_bfr2=1) ELSE (set s_bfr2=2)
	)
) ELSE (set s_bfr2=2)

IF EXIST "mod\games\Rudra 2029 Pilot\data" (
	IF EXIST "mod\games\Rudra 2029 Pilot\palettes\enemies"		(set s_r2029=0) ELSE (
		IF EXIST "mod\r2029.txt"				(set s_r2029=1) ELSE (set s_r2029=2)
	)
) ELSE (set s_r2029=2)


IF EXIST "mod\games\Rage Rise of The Black Dragon\palettes\enemies"	(set s_bdrag=0) ELSE (
	IF EXIST "mod\bdragon.txt"					(set s_bdrag=1) ELSE (set s_bdrag=2)
)

IF EXIST "mod\games\SoR3 - Adam's Story Extended\palettes\enemies"	(set s_sor3a=0) ELSE (
	IF EXIST "mod\sor3adam.txt"					(set s_sor3a=1) ELSE (set s_sor3a=2)
)

IF EXIST "mod\games\Rushing Beat Remake FE v2.1\data" (
	IF EXIST "mod\games\Rushing Beat Remake FE v2.1\palettes\enemies"	(set s_rush=0) ELSE (
		IF EXIST "mod\rushing.txt"					(set s_rush=1) ELSE (set s_rush=2)
	)
) ELSE (set s_rush=2)

IF EXIST "mod\games\SoR1 Collection for V5 Vecta\data" (
	IF EXIST "mod\games\SoR1 Collection for V5 Vecta\palettes\enemies"	(set s_sor1=0) ELSE (
		IF EXIST "mod\sor1.txt"						(set s_sor1=1) ELSE (set s_sor1=2)
	)
) ELSE (set s_sor1=2)

IF EXIST "mod\games\SoR2 Collection for V5 U\data" (
	IF EXIST "mod\games\SoR2 Collection for V5 U\palettes\enemies"	(set s_sor2=0) ELSE (
		IF EXIST "mod\sor2.txt"					(set s_sor2=1) ELSE (set s_sor2=2)
	)
) ELSE (set s_sor2=2)

IF EXIST "mod\games\SoR3 Ultimate Mod for V5\data" (
	IF EXIST "mod\games\SoR3 Ultimate Mod for V5\palettes\enemies"	(set s_sor3=0) ELSE (
		IF EXIST "mod\sor3.txt"					(set s_sor3=1) ELSE (set s_sor3=2)
	)
) ELSE (set s_sor3=2)

IF EXIST "mod\games\Rescue Metro City\data" (
	IF EXIST "mod\games\Rescue Metro City\palettes\enemies"		(set s_metro=0) ELSE (
		IF EXIST "mod\metro.txt"				(set s_metro=1) ELSE (set s_metro=2)
	)
) ELSE (set s_metro=2)

IF EXIST "mod\games\Nightsweeper v1.4\palettes\enemies"		(set s_hunterg=0) ELSE (
	IF EXIST "mod\hunterg.txt"				(set s_hunterg=1) ELSE (set s_hunterg=2)
)

IF EXIST "mod\games\DOA\palettes\enemies"	(set s_doa=0) ELSE (
	IF EXIST "mod\doa.txt"			(set s_doa=1) ELSE (set s_doa=2)
)

IF NOT EXIST "mod\games\V4 Remake v1.4"		(set s_v4=2) ELSE (
	IF EXIST "mod\v4.txt"			(set s_v4=1) ELSE (set s_v4=0)
)

IF NOT EXIST "mod\games\SoRR v4 Bonus - Rudra's Story"	(set s_v4rudra=2) ELSE (
	IF EXIST "mod\v4rudra.txt"			(set s_v4rudra=1) ELSE (set s_v4rudra=0)
)

IF EXIST "mod\games\Vendetta Dead End City Stories v1.0\data" (
	IF EXIST "mod\games\Vendetta Dead End City Stories v1.0\palettes\enemies"	(set s_vendetta=0) ELSE (
		IF EXIST "mod\vendetta.txt"						(set s_vendetta=1) ELSE (set s_vendetta=2)
	)
) ELSE (set s_vendetta=2)

IF EXIST "mod\games\Night Slashers\data" (
	IF EXIST "mod\games\Night Slashers\palettes\enemies"	(set s_nslash=0) ELSE (
		IF EXIST "mod\nslashers.txt"			(set s_nslash=1) ELSE (set s_nslash=2)
	)
) ELSE (set s_nslash=2)

IF EXIST "mod\games\Street Fighter II\data" (
	IF EXIST "mod\games\Street Fighter II\palettes\enemies"	(set s_sf2=0) ELSE (
		IF EXIST "mod\sf2.txt"				(set s_sf2=1) ELSE (set s_sf2=2)
	)
) ELSE (set s_sf2=2)

IF EXIST "mod\games\Additional Rage v1.1\data" (
	IF EXIST "mod\games\Additional Rage v1.1\palettes\enemies"	(set s_addrage=0) ELSE (
		IF EXIST "mod\addrage.txt"				(set s_addrage=1) ELSE (set s_addrage=2)
	)
) ELSE (set s_addrage=2)

IF EXIST "mod\games\Way of the Warrior\palettes\enemies"	(set s_wayw=0) ELSE (
	IF EXIST "mod\wayw.txt"					(set s_wayw=1) ELSE (set s_wayw=2)
)
