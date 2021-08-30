/*
* Created by rrenamed
* Feel free to contribute explanations
*/

#include <iostream>
#include <math.h>

using namespace std;
int main() {
    int test_cases;
    cin >> test_cases;
    //Getting the number of testing cases
    while (test_cases--)
    {
        int _case;
	    cin >> _case;
        //Getting case
        int sqrtF = floor(sqrt(_case));
        //Getting floor of case
        int sqrtC = ceil(sqrt(_case));
        //Ceiling case
        if (sqrtC * sqrtC - _case > _case - sqrtF * sqrtF) //Checking what sqrt is closer to case
            cout << _case - sqrtF * sqrtF << " " << sqrtC << "\n";
        else
            cout << sqrtC << " " << sqrtC * sqrtC - _case + 1 << "\n";
    }
  return 0;
}
