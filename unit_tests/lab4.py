import math
import pytest

#to verify unit tests use python -m pytest .\testy_lab4.py -vvv

def quadratic_equation(a, b, c):
    # obliczanie delta
    delta = b**2 - 4*a*c
    
    # brak pierwiastków rzeczywistych
    if delta < 0:
        return "brak pierwiastków rzeczywistych"
    # jeden pierwiastek rzeczywisty
    elif delta == 0:
        x = (-b + math.sqrt(delta)) / (2*a)
        return f"x = {x}"
    # dwa pierwiastki rzeczywiste
    else:
        x1 = (-b + math.sqrt(delta)) / (2*a)
        x2 = (-b - math.sqrt(delta)) / (2*a)
        return f"x1 = {x1}, x2 = {x2}"

print (quadratic_equation(5, 0, 6))
print (quadratic_equation(1, 0, -8)) 
print (quadratic_equation(2, 5, 3)) 
print (quadratic_equation(1, -3, 4)) 
print (quadratic_equation(3, 2, 1)) 


    