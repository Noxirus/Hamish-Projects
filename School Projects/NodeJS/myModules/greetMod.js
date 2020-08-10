const myGreetings = [];
myGreetings[0] = "Server good to go on port 8000";
myGreetings[1] = "The server is ready on port 8000";
myGreetings[2] = "Open on 8000";
myGreetings[3] = "The beacons are lit! 8000 calls for aid!";
myGreetings[4] = "Im awake... Im awake"

	exports.randomGreeting = function () {
		var randNum = Math.floor(Math.random()*myGreetings.length);
		return myGreetings[randNum];
	};
	
	//exports.greeting = ()=> randomGreeting;