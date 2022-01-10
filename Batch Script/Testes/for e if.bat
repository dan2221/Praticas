For %%G IN (
	palettes
	palettes\chars
	palettes\backup_chars
) do (
	if not exist "mod\chars\blaze\%%G" (mkdir "mod\chars\blaze\%%G")
)