#include <iostream>
using namespace std;
int main() {
    int n,sum=0,ld,sno,lno;
    cout<<"Enter start range of amrstrome Number  ";
    cin>>sno;
    cout<<"Enter last range of amrstrome Number  ";
    cin>>lno;
    int temp;
    for(n=sno;n<=lno;n++){
         temp=n;
    while(temp != 0){
        ld=temp%10;
        sum=sum+(ld*ld*ld);
        temp=temp/10;
    }
    
    if(sum==n){
        cout<<n<<"Armstrome";
    
    }
    }
    cout<<endl;
        
    
    
    
        
    
    return 0;
}