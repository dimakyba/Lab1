#include <iostream>
#include <cmath>

using namespace std;

int main() {
    cout << "Введіть х: ";
    double x;
    cin >> x;
    double y = pow(2, x) * x * cos(x) + 1;
    cout << y << endl;

    return 0;
}

