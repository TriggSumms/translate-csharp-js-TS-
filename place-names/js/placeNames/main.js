//import React, { useState } from "react";
//import { Route, Link } from "react-router-dom";


function main() {

names = [ "Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

for (let name  of names) {
  console.log(`${name}.`);
}
console.log("blank space", name);




theNames = names; 
theNames.find((the)=>the.theNames == "The");

console.log("answerToStartingThe", the );

for (let name2  of theNames) {
  console.log(`${name2}`);
}


}

main();