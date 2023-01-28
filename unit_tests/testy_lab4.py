import math
import pytest

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

# testy jednostkowe
print (quadratic_equation(5, 0, 6))
print (quadratic_equation(1, 0, -8)) 
print (quadratic_equation(2, 5, 3)) 
print (quadratic_equation(1, -3, 4)) 
print (quadratic_equation(3, 2, 1)) 

#test brak pierwiastkow rzeczywistych
def get_no_real_elements(a: int,b: int, c: int) -> int:
    delta = b**2 - 4*a*c
    return delta < 0

def test_no_real_elements(capsys): #capture system - pobiera eventy systemowe, mozna dzieki temu pobierac to co zwraca program
    # try
    a = 1
    b = 0
    c = 1

    #when
    result = get_no_real_elements(a, b, c)
    
    #then
    assert result


def get_1_real_element(a: int,b: int, c: int) -> int:
    delta = b**2 - 4*a*c
    return delta == 0

def test_1_real_element(capsys): #capture system - pobiera eventy systemowe, mozna dzieki temu pobierac to co zwraca program
    # try
    a = 1
    b = -2
    c = 1

    #when
    result = get_1_real_element(a, b, c)
    
    #then
    assert result


def get_2_real_elements(a: int,b: int, c: int) -> int:
    delta = b**2 - 4*a*c
    return delta > 0

def test_2_real_elements(capsys): #capture system - pobiera eventy systemowe, mozna dzieki temu pobierac to co zwraca program
    # try
    a = 1
    b = 0
    c = -3

    #when
    result = get_2_real_elements(a, b, c)
    
    #then
    assert result


    