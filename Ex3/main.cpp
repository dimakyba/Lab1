#include <iostream>

using namespace std;

int main() {
    double x, y;
    cin >> x >> y;
    bool isInsideEllipse = ((x * x / 9 + y * y) <= 1 && y >= 0);
    bool isInsideRectangle = (x >= -1 && x <= 1 && y >= -2 && y <= 0);

    if (isInsideEllipse || isInsideRectangle) {
        cout << "YES" << endl;
    } else {
        cout << "NO" << endl;
    }

}