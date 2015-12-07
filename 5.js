var fs = require('fs');
var os = require('os');

var EOL = os.EOL;

rules = [];

rules.push(function(string){
	console.log(string);
	return string.split('').filter(function(text){return ['a', 'e', 'i', 'o', 'u'].indexOf(text.toLowerCase()) >= 0}).length >= 3;
});

fs.readFile('5.input.txt', 'utf8', function(err, data){
	data.split(EOL).forEach(
		function(string){
			console.log(rules[0](string));
		});
});