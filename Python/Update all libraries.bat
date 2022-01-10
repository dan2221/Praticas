@echo off
:: paste on your console window
pip freeze | %{$_.split('==')[0]} | %{pip install --upgrade $_}