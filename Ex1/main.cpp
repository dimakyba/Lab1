#include <iostream>

using namespace std;

int main() {
    double t_time, v_speed, s_way;
    cout << "Введіть час: ";
    cin >> t_time;
    cout << "Введіть швидкість: ";
    cin >> v_speed;
    s_way = t_time * v_speed;
    cout << "За " << t_time << " годин, рухаючись зі швидкістю " << v_speed << " км/год, автомобіль проїде " << s_way << " км." << endl;


    return 0;
}
