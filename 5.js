var fs = require('fs');

var applyRules = function(value, rules) {
  var result = true;
  rules.forEach(function(rule){
    result = result && rule(value);
  });

  return result;
};

var repeatingDoubleLetter = function(str){
  var testString = str.substring(0,2);
  while(testString.length === 2){
    //replace the first appearance of teststring, and check for any more
    if(str.replace(testString, "").indexOf(testString) !== -1){
      return true;
    }

    str = str.substring(1);
    testString = str.substring(0, 2);
  }
  return false;
};

var oneLetterRepeating = function(str){
  while(str.length >= 3){
    if(str[0] === str[2]){
      return true;
    }
    // Chop of first char
    str = str.substring(1);
  }
  return false;
};

(function(){
  var rules = [];

  rules.push(repeatingDoubleLetter);
  rules.push(oneLetterRepeating);

  var niceCount = 0;

  var fileData = fs.readFileSync("5.input", 'utf-8');

  testStrings = fileData.split("\n");
  testStrings.forEach(function(str){
    if(applyRules(str, rules)){
      niceCount += 1;
    }
  });
  
  console.log(niceCount);

})();
