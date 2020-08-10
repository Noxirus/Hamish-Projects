const greet = require("./myModules/greetMod");
const express = require("express");
const bodyParser = require("body-parser");
const server = express();
const monk = require("monk");
const db = monk('localhost:27017/travelexperts');
const mongo = require("mongodb").MongoClient;
const url = "mongodb://localhost:27017/travelexperts";
const moment = require("moment");
var myDate = moment().format("MMMM Do, YYYY");
var regData = [];

//connect to the server
server.listen(8000, ()=>{
	console.log(greet.randomGreeting());
});

server.use(bodyParser.urlencoded({ extended: true }));

//get ejs pages
server.get('/rando', (req, res)=>{
	res.send("<h1>" + greet.randomGreeting() + "</h1>");
});
//posting registration to the database
server.post("/register_form", (req, res) => {
	regData[0] = req.body.fname;
	regData[1] = req.body.lname;
	regData[2] = req.body.address;
	regData[3] = req.body.postal;
	regData[4] = req.body.email;

	mongo.connect(url, { useUnifiedTopology: true }, (err, db) => {
		if (err) {
			throw err;
		} else {
			var dbo = db.db('travelexperts');
			var newData = {
				CustFirstName: regData[0],
				CustLastName: regData[1],
				CustAddress: regData[2],
				CustPostal: regData[3],
				CustEmail: regData[4]
			}
			dbo.collection('customers').insertOne(newData, (err, result) => {
				if(err){
					throw err;
				} else {
				}
				db.close();
				res.send("Thanks so much for registering " + regData[0]);
			});	
		}
	});
});

//response to sending a message on the contact form
server.post("/contact_form", (req, res) => {
	var userName = req.body.name;
	res.send("Thanks for your message " + userName);
	console.log(req.body.message);
});

//adding a current date to the index page
server.get('/index', function (req, res, next) {
	res.render('index.ejs', {
		title: 'Welcome to Travels R Us',
		clock: myDate
	});
});

server.get('/register', function (req, res) {
		res.render('register.ejs',
			{
				title: "Register Now",
			});
	});

	// sending the agents section of the database to contacts page
server.get('/Contact', function (req, res, next) {
	const agents = db.get('agents');
	
	res.render('contact.ejs', {
		title: 'Contact Us!',
		agentPer: agents
	});
});

//let use find pages
server.use(express.static("views", { 
	extensions: ["ejs"]
}));
server.use(express.static("public"));

server.get('/', function(req, res, next) {
	res.render('index.ejs', {
		title: 'Welcome to Travels R Us',
		clock: myDate
	});
});
//404 error
server.use((req, res, next) => {
	res.status(404).render('404.ejs');
});
