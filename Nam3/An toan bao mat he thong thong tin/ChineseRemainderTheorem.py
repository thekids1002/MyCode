import string
# Giải thuật tìm phần dư trung hoa
def ChineseRemainderTheorem(a,r1,b,r2):
    (d,x,y) = extended_gcd(a,b)
    n = (r2 * a * x ) + (r1 * b * y)
    m = (a *b )
    return (n%m)

def extended_gcd(a,b):
    assert a >= b and b >= 0 and a+b > 0
    if b == 0:
        d,x,y = a,1,0
    else:
        (d,p,q) = extended_gcd(b,a%b)
        x = q
        y = p - q *(  a // b)
    assert a % d  == 0 and b % d == 0
    assert d ==  a * x + b * y
    return (d,x,y)

print("x =" + str(ChineseRemainderTheorem(17,6,13,5)))
#output x =  57 
      
 