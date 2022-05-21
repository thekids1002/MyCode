#giải thuật luỹ thừa nhanh
def fast_exp(b, e, m):
    r = 1
    if 1 & e:
        r = b
    while e:
        e >>= 1
        b = (b * b) % m
        if e & 1: r = (r * b) % m
    return r

b = 100
e = 200
m = 59
r = fast_exp(b, e, m)
print("{} ^ {} ≡ {} (mod {})".format(b, e, r, m))
#output 31 ^ 101 ≡ 159 (mod 1024)