#include <iostream>
#include <vector>
using namespace std;

int get_factors_count(long long int number) {
    int count = 0;
    for (int i = 1; i * i <= number; ++i) {
        if (number % i == 0) {
            count += 2;
            if (i * i == number) {
                --count;
            }
        }
    }
    return count;
}

int main() {
    long long int a = 1, b = 1, temp = 0;
    while (true) {
        temp = a; 
        a = b; 
        b = temp + b;
        if (get_factors_count(a) >= 1000) {
            cout << a << endl;
            return 0;
        }
    }
}
