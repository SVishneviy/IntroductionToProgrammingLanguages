System.Console.Write("Enter first number: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0) {
  print(m, n);
  System.Console.WriteLine("Sum: " + sum(m, n));
  System.Console.WriteLine("Akkerman: " + akkerman(m, n));
} else {
  System.Console.WriteLine("Numbers is not positive");
}

static void print (int m, int n) {
  if (n < m) {
    return;
  }
  print(m, n - 1);
  System.Console.WriteLine(n);
}

static int sum(int m, int n) {
  if (m == n) {
    return m;
  } 
  return m + sum(m + 1, n);
}

static int akkerman(int m, int n) {
  if (m == 0) {
    return n + 1;
  } else if (m > 0 && n == 0) {
    return akkerman(m - 1, 1);
  } else if (m > 0 && n > 0) {
    return akkerman(m - 1, akkerman(m, n - 1));
  } else {
    return 0;
  }
}