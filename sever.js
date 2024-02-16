const connect = require('connect');
const http = require('http');

// Create a Connect application
const app = connect();

// Middleware to respond with "Hello, World!"
app.use((req, res) => {
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  res.end('Hello, World!\n');
});

// Create an HTTP server with the Connect application
http.createServer(app).listen(3000, () => {
  console.log('Server is running on http://localhost:3000/');
});
