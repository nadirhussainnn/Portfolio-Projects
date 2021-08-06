#include<iostream>
#include<conio.h>
#include<fstream>
#include<string.h>
#include<string>
#include<iomanip>
#include<windows.h>
#include<time.h>
#include<cstdlib>//for random function
using namespace std;
struct Node;
//functions' prototypes
int loginToAccount();	
void createAccount();	
void buyATicket(string &dest, string &current);
void changeAccountInfo(string pin, string user_name);
void readOnlyData();	
bool previousTravels(string nameToSearch, string pinToCompare, Node *objectToAcessTree);
string chooseLocations();
void graphingAllPossiblePathsFromCurrentLocationToDestination(string &fileName, string &city, int &i, int &j, double &dist);
void showAllPossiblePaths(int sums[], int start, int j, string destinationName);
void getRandomHours();
void getRandomMinutes();
void chooseTrain();
void printTicket(string pin, string user_name, string current, string destination);
void replaceTreeData(string newName, string newMob, string newMail, string newPassword, string password, string searchName);
int *hours=new int[12];
int *minutes2=new int[60];
void writeTreeDataToFile(Node *&p);
void initializeWholeProgram();
struct Node{
	string name, password, address, mobile, email, input, destination, current, dist, rent, date;
	Node *left, *right, *next, *down;
	double distance;
};
struct Tree_to_Store_DATA{
	Node *root, *newNode, *current;
	Tree_to_Store_DATA(){
	root=current=newNode=0;
	}
		void createDataTree(string name, string password, string mobile, string email){
		newNode=new Node;
		newNode->name=name;
		newNode->email=email;
		newNode->mobile=mobile;
		newNode->password=password;
		newNode->left=newNode->right=newNode->down=0;
		if(!root){
			root=newNode;
		}
		else{
			current=root;
			while(current){
				if(name>current->name && current->right==NULL){
					current->right=newNode;
					break;
				}
				else if(name>current->name && current->right!=NULL){
					current=current->right;
				}
				else if(name<current->name && current->left==NULL){
					current->left=newNode;
					break;
				}
				else if(name<current->name && current->left!=NULL){
					current=current->left;
				}
			}
		}
	}
	void createDataTree(string name[]){
		newNode=new Node;
		newNode->password=name[0];
		newNode->name=name[1];
		newNode->mobile=name[2];
		newNode->email=name[3];
		
		newNode->destination=name[4];
		newNode->current=name[5];
		newNode->dist=name[6];
		newNode->rent=name[7];
		newNode->date=name[8];
		newNode->left=newNode->right=newNode->down=0;
		if(!root){
			root=newNode;
		}
		else{
			current=root;
			while(current){
				
				if(name[1]==current->name){
					Node *temp=current;
					while(temp->down){
						temp=temp->down;
					}
					temp->down=newNode;
					break;
				}
				else if(name[1]>current->name && current->right==NULL){
					current->right=newNode;
					break;
				}
				else if(name[1]>current->name && current->right!=NULL){
					current=current->right;
				}
				else if(name[1]<current->name && current->left==NULL){
					current->left=newNode;
					break;
				}
				else if(name[1]<current->name && current->left!=NULL){
					current=current->left;
				}
			}
		}
	}
	bool searchFromDataTree(string searchPin, string searchName){

	Node *temp=root;
	bool cond=false;
	while(temp){
		if(temp->password==searchPin && searchName==temp->name){
			cond=true;
			break;
			}
		else if(temp->name>searchName){
			temp=temp->left;
		}
		else
			temp=temp->right;
		}
	return cond;
	}
	void searchFromDataTree(string searchPin, string searchName, Node *&pointer, bool &cond){

	pointer=root;
	cond=false;
	while(pointer){
		if(pointer->password==searchPin && searchName==pointer->name){
			cond=true;
			break;
			}
		else if(pointer->name>searchName){
			pointer=pointer->left;
		}
		else
			pointer=pointer->right;
		}
	}
	void destroyTree(Node *&p){
		if(p){
			destroyTree(p->left);
			destroyTree(p->right);
			delete p;
			p=NULL;
		}
	}
	
	void inorder(Node *p){
		if(p){
			inorder(p->left);
			cout<<p->name<<endl<<p->password<<endl<<p->current<<p->mobile<<p->email<<endl;
			inorder(p->right);
		}	
	}

};
struct Graph{
	Node *nN, *head, *current;
	string vertex;
	int distance, sum;
	Graph(){
	distance=sum=0;
	nN=head=current=0;
	}
	void insertAdjacents(string cityName, double dist){
		nN=new Node;
		nN->next=NULL;
		nN->name=cityName;
		nN->distance=dist;
		if(head==NULL){
			head=nN;
			current=nN;
		}
		else{
			current->next=nN;
			current=nN;
		}
	}
}; 

//Global Variables
ifstream readFile;
ofstream writeFile;
string name, password, address, mobile, email, pinCode;
char absorb;
int choice, index=0;
double rent=0, dist;
Tree_to_Store_DATA accessObject;
Graph *cities=new Graph[50];
int main(){
	time_t now=time(0);
	char* ch=ctime(&now);

	char goBack;
while(true){
	cout<<endl<<"\t\t\t\t"<<ch<<endl;
	mainMenu:
	cout<<endl<<endl;
	cout<<"\t\t      ****************************************    "<<endl;Sleep(200);  		
	cout<<"\t\t    *******                               *******"<<endl;Sleep(500);
	cout<<"\t\t  ******    Pakistan Railways Service        *******"<<endl;Sleep(200);
	cout<<"\t\t    *******                               *******"<<endl;Sleep(500);
	cout<<"\t\t      ****************************************    "<<endl<<endl<<endl;Sleep(200);
	again:
	cout<<"\t\t\t Enter "<<endl;
	cout<<"\t\t\t 1. to Login "<<endl;
	cout<<"\t\t\t 2. to create new Account "<<endl;
	int choice;
	cout<<endl<<"\t\t\t ";
	cin>>choice;
	system("CLS");
	switch(choice){
	case 1:
		
		readOnlyData();
		cout<<endl<<endl;
		loginToAccount();
			cout<<endl<<"\t\t\t Enter B to go to Main Menu or E to EXIT "<<endl<<"\t\t\t";
			inputAgain:
			cin>>goBack;
			
			switch(goBack){
			case 'B':case 'b':
				initializeWholeProgram();
				system("CLS");
				goto mainMenu;
				break;
			case 'E': case 'e':
				return 0;
			default:
				cout<<"\t\t\t Invalid choice.....Please enter again: "<<endl<<"\t\t\t";
				goto inputAgain;
			}
	break;
	case 2:
		cout<<endl<<endl;
		createAccount();
		cout<<endl<<"\t\t\t Enter B to reach Main Menu or E to EXIT "<<endl<<"\t\t\t";
		char ch;
		Back:
		cin>>ch;
		switch(ch){
		case 'B':case 'b':
			initializeWholeProgram();
			system("CLS");
			goto mainMenu;
			break;
		case 'E': case 'e':
			return 0;
		default:
			cout<<"\t\t\t Invalid choice.....Please enter again: "<<endl<<"\t\t\t";
			goto Back;
		}

		break;
	default:
		cout<<"\t\t\t Enter valid choice :"<<endl<<"\t\t\t";
		goto again;
		break;	
	}
		
	}		
	_getch();
}
//functions' body
int loginToAccount(){

		Tree_to_Store_DATA obj;
		string str[10];
		int x=0, limit=0;
		bool foundPrevious=false, exited=false;
		string pin, user_name, dest="", current="";
		up:
		cout<<"\t\t\t Enter Name: ";
		cin.get(absorb);
		getline(cin,user_name);
		cout<<"\t\t\t Enter Account PIN: ";
		cin>>pin;
		bool isAcountPresent=accessObject.searchFromDataTree(pin, user_name);
		if(isAcountPresent){
			again:
			cout<<"\t\t\t Choose any option to: "<<endl<<endl;
	
			cout<<"\t\t\t 1. Buy a ticket: "<<endl;
			cout<<"\t\t\t 2. Edit Account: "<<endl;
			cout<<"\t\t\t 3. View Previous Travels: "<<endl<<endl;
			cout<<"\t\t\t ";
			cin>>choice;
			switch(choice){
			case 1:
				buyATicket(dest, current);
				cout<<endl<<"\t\t\t Ticket Information "<<endl;
				printTicket(pin, user_name,  current, dest);
				
				break;
			case 2:
				changeAccountInfo(pin, user_name);
				break;
			case 3:	
				obj.root=NULL;
				
				readFile.open("PreviousTravels.txt");
				while(!readFile.eof()){
				getline(readFile, str[x]);	
				if(str[x]==";"){
					obj.createDataTree(str);
					x=0;
				}
					else
						x++;
				}
				foundPrevious=previousTravels(user_name,pin, obj.root);
				readFile.close();
				if(!foundPrevious){
					cout<<"\t\t\t\tNo previous Travels found from: "<<user_name<<endl<<endl;
					cout<<endl<<"\t\t\t\tEnter B to go Back: ";
					char ch;
					input:
					cin>>ch;
					switch(ch){
					case 'B':
					case 'b':
						system("CLS");
						cout<<endl<<endl;
						goto again;
						break;
					default:
						cout<<endl<<"\t\t\t\tEnter B please ";
						goto input;
					break;
					goto again;
					}
				}
					
			break;
			default:
				cout<<"Enter Valid choice: "<<endl;
				goto again;
				break;

			}
		}
		else{
			limit++;
			if(limit<=2){
				cout<<endl<<"\t\t\t No Such Record found..........."<<endl<<endl<<"\t\t\t Enter correct Information......."<<endl;
				goto up;
			}
			else{
				cout<<endl<<"\t\t\t\t....... Password Limit exceeded......... "<<endl;
				return 0;
			}
		}
		return 0;
}
void buyATicket(string &dest, string &current){										//this function is called on choice in LoginAccount Function
	
	string city="", fileAddress="";
	int i=0, j=0, trainChoice, start=0, sums[100]={0,0};
	double dist=0;
	
	cout<<endl<<"\t\t\t Enter your current Location: "<<endl<<endl;	
	string currentCity=current=chooseLocations();
	cout<<endl<<"\t\t\t Enter your destination: "<<endl<<endl;
	again:
	string destination=dest=chooseLocations();
	if(destination==currentCity){
	cout<<"\t\t\t Please Enter other destination :"<<endl<<endl;
	goto again;
	}
	
	cout<<"\t\t Departure time of all trains from "<<currentCity<<" to "<<destination<<" : "<<endl<<endl;
	cout<<"\t\t\t Select any train from: 1-12 "<<endl;
	up:
	chooseTrain();
	cout<<"\t\t\t";
	cin>>trainChoice;

if(trainChoice>=1 && trainChoice<=12){
	if(currentCity=="islamabad"){
		fileAddress="Stations/IslamabadStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="lahore"){
		fileAddress="Stations/LahoreStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="karachi"){
		fileAddress="Stations/KarachiStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="peshawar"){
		fileAddress="Stations/PeshawarStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="quetta"){
		fileAddress="Stations/QuettaStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="sukkur"){
		fileAddress="Stations/SukkurStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="multan"){
		fileAddress="Stations/MultanStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="rohri"){
		fileAddress="Stations/RohriStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="nawabshah"){
		fileAddress="Stations/NawabShahStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
	}
	else if(currentCity=="hyderabad"){
		fileAddress="Stations/HyderabadStation.txt";
		graphingAllPossiblePathsFromCurrentLocationToDestination(fileAddress, city, i, j, dist);
		showAllPossiblePaths(sums,start,j, destination);
		}	
	}
	else{
		cout<<"No other train will depart today.... So please select from below list: "<<endl<<endl;
		goto up;
	}
}// buyTickect ends here
void changeAccountInfo(string pin, string user_name){
	
	
	string naam, paas,eMail, addres, moBile;
	cin.get(absorb);
	cout<<"\t\t\t Write new Name: ";
	getline(cin, naam);
	cout<<"\t\t\t Write new Mob#: ";
	cin>>moBile;
	cout<<"\t\t\t Write new E-Mail: ";
	cin>>eMail;
	cin.get(absorb);
	cout<<"\t\t\t Write new Address: ";
	getline(cin, addres);
	cout<<"\t\t\t Write new Password: ";
	cin>>paas;
	
	replaceTreeData(naam, moBile, eMail, paas, pin, user_name);

}// this function is called as choice in Login Account
bool previousTravels(string nameToSearch, string pinToCompare, Node *objectToAcessTree){
	
	system("CLS");
	cout<<endl<<endl;
	cout<<"\t\t\t ------------------------------------------------------"<<endl;
	cout<<endl<<"\t\t\t\t All previous Travel records of "<<nameToSearch<<endl;
	cout<<"\t\t\t ------------------------------------------------------"<<endl;
	bool isAccountPresent=false;
	cout<<endl<<"\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ "<<endl;
	while(objectToAcessTree){
		if(objectToAcessTree->password==pinToCompare && nameToSearch==objectToAcessTree->name){
			cout<<"\t\t\t\tFrom : "<<objectToAcessTree->current<<endl;
			cout<<"\t\t\t\tTo : "<<objectToAcessTree->destination<<endl;
			cout<<"\t\t\t\tDate :"<<objectToAcessTree->date<<endl<<endl;
			cout<<"\t\t\t\tDistance traveled:  "<<objectToAcessTree->dist<<" KM(s) "<<endl;
			cout<<"\t\t\t\tFair paid:  "<<objectToAcessTree->rent<<" Rupees "<<endl;
			cout<<endl<<"\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ "<<endl;
			isAccountPresent=true;
			objectToAcessTree=objectToAcessTree->down;
		}
		else if(objectToAcessTree->name>nameToSearch){
			objectToAcessTree=objectToAcessTree->left;
		}
		else if(objectToAcessTree->name<nameToSearch){
				objectToAcessTree=objectToAcessTree->right;
		}
	}
		cout<<endl;
		return isAccountPresent;
	}
void createAccount(){
	
	createAgain:
	writeFile.open("Accounts.txt", ios::app);
	if(!writeFile.fail()){
			cout<<"\t\t\tFirst Name: ";
			cin>>name;
			cout<<"\t\t\t Mobile: ";
			cin>>mobile;
			cout<<"\t\t\t E-Mail: ";
			cin>> email;
			cout<<"\t\t\t Address: ";
			cin.get(absorb);
			getline(cin, address);
			cout<<"\t\t\t Password: ";
			cin>>password;
			writeFile<<password<<"    "<<mobile<<"    "<<email<<"   "<<name<<endl;
			//for data base
			writeFile.close();
			int x;
			readFile.close();
			readFile.open("NumberUpdater.txt");
			readFile>>x;
			writeFile.open("NumberUpdater.txt");
			writeFile<<x+1;
	}
	else{
		cout<<"\t\t\t Temporary error occured in DATABASE"<<endl;Sleep(500);
	}
			writeFile.close();
			readFile.close();
			system("CLS");
			cout<<endl<<endl<<"\t\t\t\t Account created Successfully......"<<endl<<endl;;
			char ch;
			cout<<"\t\t\tCreate an other Account? Y/N: ";
			cin>>ch;
			switch(ch){
			case 'Y':
			case 'y':
				goto createAgain;
				break;
			default:	
				break;
			}
}
void readOnlyData(){
	
	int numberOfrecords;
	readFile.close();
	readFile.open("NumberUpdater.txt");
	readFile>>numberOfrecords;
	readFile.close();
	
	readFile.open("Accounts.txt");	 
	for(int i=0;i<numberOfrecords;i++){	
		
			readFile>>password;
			readFile>>mobile;
			readFile>>email;
			readFile>>name;
		accessObject.createDataTree(name, password,mobile,email);		
	}
	readFile.close();
}
string chooseLocations(){

	readFile.open("LocationOrDestination.txt");
	cout<<"\t\t\t ----------------------------"<<endl;
	while(!readFile.eof()){
		getline(readFile, name);
		cout<<"\t\t\t "<<name<<endl;
	}
	cout<<"\t\t\t ----------------------------"<<endl;
again:
	cout<<"\t\t\t";
	cin>>name;
	for(int i=0;i<name.length();i++){
		if(int(name[i])>=65 && int(name[i])<=92){
		name[i]+=32;
		}
	}
	if(name=="sukkur" || name=="islamabad" ||name=="lahore" ||name=="quetta" ||name=="hyderabad" ||name=="multan" ||name=="rohri" ||name=="nawabshah" ||name=="peshawar" || name=="karachi");
	else{
		cout<<endl<<"\t\t\t Please enter Correct City Name: ";
		goto again;
	
	}
	readFile.close();
	return name;
}
void graphingAllPossiblePathsFromCurrentLocationToDestination(string &fileName, string &city, int &i, int &j, double &dist){
	readFile.close();
	readFile.open(fileName);
		while(!readFile.eof()){
			readFile>>city;
			if(i==0){
				cities[j].vertex=city;
			}
			if((int(city[0])>=65 && int(city[0])<=92) || (int(city[0])>=97 && int(city[0])<=122) && i>0){			//() can change something here
				cities[j].insertAdjacents(city, dist);
				dist=0;
				city="";
			}
			else if(int(city[0])>=48 && int(city[0])<=57 && i>0){
				dist=stoi(city);
			}
			i++;
			if(city==";"){
			j++;
			i=0;
			}
		}						
			readFile.close();
}
void showAllPossiblePaths(int sums[], int start, int j, string destinationName){
	Graph *possiblePaths=new Graph[j];
	system("CLS");
	cout<<endl<<endl<<endl<<"\t\t\t *******************************************************"<<endl;
	cout<<"\t\t\t\t All possible paths to reach "<<destinationName<<endl;
	cout<<"\t\t\t *******************************************************"<<endl;
	for(int k=0;k<j-1;k++){
				Node *temp=NULL;
				temp=cities[k].head;
				while(temp->next){
					temp=temp->next;
				}
				for(int x=0;x<temp->name.length();x++){
					if(int(temp->name[x])>=65 && int(temp->name[x])<=92)
					temp->name[x]+=32;
				}
				if(temp->name==destinationName){
				cout<<endl<<endl<<"\t    "<<start+1<<".  ";	
					Node *use=cities[k].head;
					while(use){	
						//sums[start]+=use->distance;
						if(use->name==destinationName){
						cout<<use->name;Sleep(200);
						}
						else
							cout<<use->name<<" ----->  ";
						possiblePaths[start].insertAdjacents(use->name, use->distance);
						use=use->next;
					}
				start++;
				}
			}
	Sleep(500);
		cout<<endl<<endl<<"\t\t\t--------------------------------------------------------"<<endl;Sleep(200);
		cout<<"\t\t\t\t Total Distance from each path"<<endl;Sleep(200);
		cout<<endl<<"\t\t\t--------------------------------------------------------"<<endl;Sleep(200);
		for(int l=0;l<start;l++){
			Node *movePtr=possiblePaths[l].head;
			while(movePtr){
				possiblePaths[l].sum+=movePtr->distance;
				movePtr=movePtr->next;
			}
		}
		for(int k=0;k<start;k++){
			cout<<endl<<"\t\t\t\t\t path "<<k+1<<"  : "<<possiblePaths[k].sum<<" KM  "<<endl;Sleep(200);
		}

		Node *moveNode=NULL;
		for(int l=0;l<start;l++){
			for(int m=0;m<start-l-1;m++){
				if(possiblePaths[m].sum>possiblePaths[m+1].sum){
					
					int swap=possiblePaths[m].sum;
					possiblePaths[m].sum=possiblePaths[m+1].sum;
					possiblePaths[m+1].sum=swap;
					moveNode=possiblePaths[m].head;
					possiblePaths[m].head=possiblePaths[m+1].head;
					possiblePaths[m+1].head=moveNode;
					}
				}
			}
		Sleep(500);
		cout<<endl<<"\t\t\t--------------------------------------------------------"<<endl;
		cout<<"\t\t\t\t -----SUGGESTION----- "<<endl;
		cout<<"\t\t\t--------------------------------------------------------"<<endl<<endl;	
		cout<<endl<<"\t\t\t\t You shoud follow this path to reach "<<destinationName<<" : "<<endl<<endl<<endl;Sleep(200);
			Node *move=possiblePaths[0].head;//need to find index value here
			cout<<"\t\t\t ";
			while(move){
				if(move->name==destinationName){
					cout<<move->distance<<"   "<<move->name;Sleep(200);}
				else
					cout<<move->distance<<"   "<<move->name<<" -----> ";
			move=move->next;
			}
			cout<<endl<<endl<<"\t\t\t--------------------------------------------------------"<<endl;
		cout<<"\t\t\t\t Total distance by this path = "<<possiblePaths[0].sum<<" KM "<<endl;Sleep(200);
		cout<<"\t\t\t--------------------------------------------------------"<<endl;
			rent=possiblePaths[0].sum*1.55;
			dist=possiblePaths[0].sum;
			
}
void chooseTrain(){
	getRandomHours();
	getRandomMinutes();
	string trains, AM_OR_PM="";
	readFile.close();
	readFile.open("AllTrains/Trains.txt");
	cout<<endl;
	for(int i=0;i<12;i++){
		getline(readFile, trains);
		if(minutes2[i]%hours[i]==0){
		AM_OR_PM="AM";
		}
		else
			AM_OR_PM="PM";
		cout<<"\t\t\t "<<trains<<"  "<<hours[i]<<" : "<<minutes2[i]<<"    "<<AM_OR_PM<<endl;
	}
	
	readFile.close();
}
void getRandomHours(){
	srand(time(NULL));
	int h[100]={};
	int x=0;
	for(int i=0;i<100;i++){
		h[i]=rand()%13;
	}
	for(int i=0;i<100;i++){
		bool flag=true;
		for(int j=i+1;j<100;j++){
			
			if(h[i]==h[j] || h[i]==0){
			flag=false;
			break;
			}
		}
		if(flag && x<=11 ){
		hours[x]=h[i];
		x++;
		}
	}
}
void getRandomMinutes(){
	srand(time(NULL));
	int m[150]={};//=new int[500];
	
	int x2=0;
	for(int i=0;i<150;i++){
		m[i]=rand()%60;
		
	}
	for(int i=0;i<150;i++){
		bool check=true;
		for(int j=i+1;j<150;j++){
			
			if(m[i]==m[j]){
			check=false;
			break;
			}
		}
		if(m[i]<=59 && check && x2<60){
			minutes2[x2]=m[i];
			x2++;
		}
	}
}
void printTicket(string PIN, string NAME, string current, string destination){
	
	time_t now=time(0);
	char* dateAndTime=ctime(&now);

	string str[10];
	int x=0;
	
	Node *point=NULL;
	bool cond=false;
	accessObject.searchFromDataTree(PIN, NAME,point, cond);
	
		cout<<"\t\t\t '''''''''''''''''''''''''''''''''''''''' "<<endl;
		cout<<"\t\t\t |\t\t Name :  "<<point->name<<endl;
		cout<<"\t\t\t |\t\t Mobile :  "<<point->mobile<<endl;
		cout<<"\t\t\t |\t\t Email : "<<point->email<<endl;
		cout<<"\t\t\t |\t\t To : "<<destination<<endl;
		cout<<"\t\t\t |\t\t From : "<<current<<endl;
		cout<<"\t\t\t |\t\t Total Distance :  "<<dist<<" KM"<<endl;
		cout<<"\t\t\t |\t\t Total Fair :  Rs. "<<rent<<endl;
		cout<<"\t\t\t |\t\t Registration Time:  "<<dateAndTime<<endl<<endl;
		cout<<"\t\t\t '''''''''''''''''''''''''''''''''''''''' "<<endl;
			
			readFile.close();
			writeFile.open("PreviousTravels.txt", ios::app);	
			writeFile<<point->password<<endl;
			writeFile<<point->name<<endl;
			writeFile<<point->mobile<<endl;
			writeFile<<point->email<<endl;
			writeFile<<destination<<endl;
			writeFile<<current<<endl;
			writeFile<<dist<<endl;
			writeFile<<rent<<endl;
			writeFile<<dateAndTime;
			writeFile<<";"<<endl;
			writeFile.close();

}//this needs to be worked on
void replaceTreeData(string newName, string newMob, string newMail, string newPassword, string password, string searchName){

	Node *temp=accessObject.root;
	while(temp){
	if(temp->password==password && searchName==temp->name){
			temp->password=newPassword;
			temp->name=newName;
			temp->mobile=newMob;
			temp->email=newMail;
			
			writeFile.open("Accounts.txt");
			writeTreeDataToFile(accessObject.root);
			writeFile.close();
			
			break;
			}
		else if(temp->name>searchName){
			temp=temp->left;
		}
		else
			temp=temp->right;
		}
}
//there is a problem in this function
void writeTreeDataToFile(Node *&p){
	if(p){

		writeFile<<p->password<<"  "<<p->mobile<<"   "<<p->email<<"  "<<p->name<<endl;
		writeTreeDataToFile(p->left);
		writeTreeDataToFile(p->right);
	}
}
void initializeWholeProgram(){

			accessObject.destroyTree(accessObject.root);
			delete []cities;
			cities=NULL;
			cities=new Graph[50];
			accessObject.root=accessObject.current=accessObject.newNode=0;
			delete []minutes2;
			minutes2=NULL;
			delete []hours;
			hours=NULL;
			minutes2=new int[60];
			hours=new int[12];
			readFile.close();
			writeFile.close();
			
}