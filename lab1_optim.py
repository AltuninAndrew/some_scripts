  import numpy as np

def func(x):
    result = (x**3)+(-x**2.718)
    return result

i = 0.
E = 1.
a = 0.
b = 1.
x1 = a
x2 = b
f1 = 0.
f2 = 0.
counter = 0
delta = 0.02

accuracy = 0.05

while E>accuracy:
    E = (b-a)/2.0
    counter+=1
    print("# ",counter,"================================")
    print("E=" , E)
    x1=a+0.381966*(b-a)
    x2=a+0.618034*(b-a)
    print("a=", a , "  b=" ,b)
    print("x1=",x1,"  x2=",x2)
    print("F(x1)= " , func(x1), "  F(x2)= ",func(x2))
    print("====================================")
    if func(x1)<func(x2):
        b = x2
    else:
        a = x1

print("E=" , E)
print("x* =" , ((a+b)/2.0) , "  F(x*) = " , (func((a+b)/2.0)) )
