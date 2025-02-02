# CPP-Codes
#include<bits\stdc++.h>
using namespace std;
int main(){
    char op;
    int n1,n2;
    cin>>n1>>n2;
    cin>>op;
    switch (op)
    {
    case '+' :
        cout<<n1+n2;
        break;
    case '-' :
        cout<<n1-n2;
        break;
    case '*' :
        cout<<n1*n2;
        break;
    case '/' :
        cout<<n1/n2;
    default:
    cout<<"Invalid";
        break;
    }
}
