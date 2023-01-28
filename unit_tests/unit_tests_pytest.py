import math
import pytest

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