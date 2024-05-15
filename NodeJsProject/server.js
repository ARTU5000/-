const express = require('express');
const app = express();
const http = require('http');
const server = http.createServer(app);
const logger = require('morgan');
const cors = require('cors');

const port = process.env.PORT || 3000;

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({
    extended: true
}))

app.use(cors());
app.disable('x-powered-by');

app.set('port', port);

server.listen(3000, '172.100.4.82' || 'localhost', function(){
    console.log('It just works! ' + port + ' acabo de iniciar...');
});

app.get ('/', (req, res) => {
    res.send("It just works! toy morido");
});

app.get ('/test', (req, res) => {
    res.send("It just works! eto e una prueba mijo!");
});