const http = require("http");
const greet = require("./myModules/greetMod");
// sends a random greeting to the console every time you start the server
http.createServer((req,res)=>{
			res.writeHead(200, { "Content-Type":"text/html" });
			res.write("<!DOCTYPE html><html><head><title>Random Greeting</title></head><body><h1>I hope you are all excited because below this will be a random greeting</h1>");
			res.write("<h2>" + greet.randomGreeting() + "</h2></body>");
			res.write("</html>");
			res.end();
}).listen(8000, ()=>{ console.log("Server has been decide"); });
