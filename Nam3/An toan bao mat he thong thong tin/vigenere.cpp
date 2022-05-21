#include<iostream>
using namespace std;
 
// Function to extend the key to the length of plaintext
string get_full_key(string pt, string k){
    if(k.size() >= pt.size())
        return k;
    else{
        int psize = pt.size()-k.size();
        int ksize = k.size(); 
        while(psize >= ksize){
            k += k;
            psize -= ksize;
        }
 
        k += k.substr(0, psize);
        return k;
    }
}
 
// Encryption Function
string get_encryption(string pt, string k){
 
    string ct = "";
    for(int i=0;i<pt.size();i++)
        if(isupper(pt[i])){
		ct += (char) (((int)pt[i]-'A' + (int)k[i]-'A') % 26) + 'A';
 		}
 		else{
 			ct += (char) (((int)pt[i]-97 + (int)k[i]-97) % 26) + 97;
		 }
    return ct;
}
 
// Decryption Function
string get_decryption(string ct, string k){
 
    string pt = "";
    for(int i=0;i<ct.size();i++)
        if(isupper(pt[i])){
		pt += (char) ((((int)ct[i]- 'A' - (k[i] -'A')) + 26) % 26) + 'A';
 		}
 		else{
 			pt += (char) ((((int)ct[i]- 97 - (k[i] -97)) + 26) % 26) + 97;
		 }
    return pt;
}
 
int main(){
 
    // The Plaintext
    string plaintext;
 
    // The key
    string key;
 	cout<<"Plaintext: ";
 	cin>>plaintext;
 	cout<<"key: ";
 	cin>>key;
    // Function call to extend the key size
    key = get_full_key(plaintext, key);
 
    cout<<" THE PLAINTEXT: "<< plaintext <<endl;
 
    
 
    // Function call to encode the data
    string ciphertext = get_encryption(plaintext, key);
 
    cout<<" THE CIPHERTEXT: "<< ciphertext <<endl;
 
    // Function call to decode the data
    plaintext = get_decryption(ciphertext, key);
 
    cout<<" THE DECODED PLAINTEXT: "<< plaintext <<endl;
 
    return 1;
}

