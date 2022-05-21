import java.util.concurrent.atomic.AtomicInteger;
/// Giải thuật Eculid mở rộng
public class EculideanExtend {

    public static int extended_gcd(int a, int b, AtomicInteger x, AtomicInteger y)
    {
        if (a == 0)
        {
            x.set(0);
            y.set(1);
            return b;
        }
 
        AtomicInteger _x = new AtomicInteger(), _y = new AtomicInteger();
        int gcd = extended_gcd(b % a, a, _x, _y);
 
        x.set(_y.get() - (b/a) * _x.get());
        y.set(_x.get());
 
        return gcd;
    }
 
    public static void main(String[] args)
    {
        int a = 25;
        int b = 10;
 
        AtomicInteger x = new AtomicInteger(), y = new AtomicInteger();
 
        System.out.println("gdc(a,b) = " + extended_gcd(a, b, x, y));
        System.out.printf("x = %d, y = %d\n", x.get(), y.get());
    }
}
