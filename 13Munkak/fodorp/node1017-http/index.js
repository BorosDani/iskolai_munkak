const http = require('http');
const PORT = 3000;

const server = http.createServer((req, res) => 
{
  res.writeHead(200, { 'Content-Type': 'text/plain; charset=utf8' });

  res.end('Hello, Árvíztűrőfúró!');
});

server.listen(PORT, 'localhost', () => 
{
  console.log(`Server running at http://localhost:${PORT}/`);
});