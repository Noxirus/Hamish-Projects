#include <iostream>
#include <ctime>
#include <cstlib>
#include <string>

using namespace std;

int main () {

//random function
srand((unsigned_int)time(0)));

//grid and placement variables
const int HORIZONTAL = 10;
const int VERTICAL = 10;
int horz=0;
int vert=0;
int direction=0;

//10 X 10 grid and validity of placement variables
char grid[HORIZONTAL][VERTICAL];
int valid = 0;
int check=0;

//Creating the full grid for play
for (i=0; i < HORIZONTAL; i++){
	for (j=0; j < VERTICAL; j++) {
		grid[i][j] = 'o';
	}
}
//large placement
while (valid == 0){
	horz=(rand() % 10);
	vert=(rand() % 10);
	direction=(rand() % 2);
		
		//heading east
		if(direction == 0 && horz < 7){
			for(i = 0; i < 4; i++){
				grid[horz][vert]='l';
				horz += horz;
			}
			valid = 1;
		}
		//heading north
		else if(direction ==1 && vert < 7){
			for(i = 0; i < 4; i++){
				grid[horz][vert]='l';
				vert += vert;
			}
			valid = 1;
		}
		else {
			valid = 0;
		}
}


//medium placement
while (valid == 1){
	 horz=(rand() % 10);
	 vert=(rand() % 10);
	 direction=(rand() % 2);
		
		//heading east plus validity check
		if(direction == 0 && horz < 8){
			for(i = 0; i < 3; i++) {
				if(grid[horz][vert] == 'o'){
					check += check;
					horz += horz;
				}
			}
			if(check != 3){
				check = 0;
			}
		}
		else if (direction == 1 && vert < 8){
			for(i = 0; i < 3; i++){
				if(grid[horz][vert] == 'o'){
					check-= check;
					vert += vert;
					}
				}
				if(check != -3){
					check = 0;
				}
			}	
		if(check == 3) {
			for(i = 0; i < 3; i++) {
				grid[horz][vert] = 'm';
				horz += horz;
			}
		valid = 0;	
	}
		else if (check == -3) {
			for(i = 0; i < 3; i++) {
				grid[horz][vert] = 'm';
				vert += vert;
			}
		valid = 0;
	}
}
//small placement
while (valid == 0){
	 horz=(rand() % 10);
	 vert=(rand() % 10);
	 direction=(rand() % 2);
		
		//heading east plus validity check
		if(direction == 0 && horz < 9){
			for(i = 0; i < 2; i++) {
				if(grid[horz][vert] == 'o'){
					check += check;
					horz += horz;
					}
				}
				if(check != 2){
					check = 0;
				}
		}
		else if (direction == 1 && vert < 9){
			for(i = 0; i < 2; i++){
				if(grid[horz][vert] == 'o'){
					check-= check;
					vert += vert;
					}
				}
				if(check != -2){
					check = 0;
				}
			}
		if(check == 2) {
			for(i = 0; i < 2; i++) {
				grid[horz][vert] = 's';
				horz += horz;
			}
		valid = 1;	
	}
		else if (check == -2) {
			for(i = 0; i < 2; i++) {
				grid[horz][vert] = 's';
				vert += vert;
			}
		valid = 1;
	}
}
/* the ships have been place is the correct random positions that are legally allowed and not intersecting */
//the game itself
int game=1;
int tries=0;
int hitcount=0;
cout << "Welcome to battleship!" << endl;
while (game == 1){

	cout << "Please enter your first coordinate: ";
	cin >> horz;
	horz -= horz;
	cout << "Please enter your second coordinate: ";
	cin >> vert;
	vert -= vert;
	tries += tries;
	
	if(grid[horz][vert] == 'o'){
		cout << "You have missed!" << endl;
		}
	else if(grid[horz][vert] == 'l') {
		cout << "You have hit the large ship!" << endl;
		grid[horz][vert] = 'h';
		hitcount += hitcount;
		cout << hitcount << "hits so far!" << endl;
	else if (grid[horz][vert] == 'm') {
		cout << "You have hit the medium ship!" << endl;
		grid[horz][vert] = 'h';
		hitcount += hitcount;
		cout << hitcount << "hits so far!" << endl;
	}
	else if (grid[horz][vert] == 's') {
		cout << "You have hit the small ship!" << endl;
		grid[horz][vert] = 'h';
		hitcount += hitcount;
		cout << hitcount << "hits so far!" << endl;
	}
	else if (grid[horz][vert] == 'h') {
		cout << "You have already hit this area of the ship!" << endl;
		hitcount += hitcount;
	}
	
	if (hitcount == 9) {
	game = 0;
	}
}

cout << "You have completed the game!" << endl;
cout << "In: " << tries << "tries!" << endl;

return 0;
}