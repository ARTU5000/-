const mysql = require('mysql');

const db = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'admin123',
    database: 'fallout'
});

db.connect(function(err){
    if (err) throw err;
    console.log ('LA BASE DE DATOS ESTA BIEN CONECTADA')
});

module.exports = db;