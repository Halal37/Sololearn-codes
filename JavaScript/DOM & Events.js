// 45 Lesson

//What is DOM?

//Document Object Model

/*
In the following HTML, which element is the parent of h1?
<body>
  <p><h1>Hi</h1></p>
</body>
*/

//p

//Select all that apply:

// innerHTML is a property
// The document object is the root of the DOM

// 46 Lesson

//Fill in the blanks to select the element with id="text" and change its content to "Hi".

var ob = document.getElementById("text");

ob.innerHTML = "Hi";

//Fill in the blanks to select all div elements and alert the content of the third div.

var arr = document.

      getElementsByTagName("div");

alert(arr[2].innerHTML);

//Can a node in the DOM have multiple parent nodes?

//No


// 47 Lesson

//Fill in the blanks to select all images of the page and change their src attribute.

var arr = document.

    getElementsByTagName("img");

for(var x=0; x<arr.length; x++) {

  arr[x].src = "demo.jpg";

}

//Fill in the blanks to change the background color of all span elements of the page.

var s = document.

    getElementsByTagName("span");

for(var x=0; x<s.length;x++) {

  s[x].style.backgroundColor = "#33EA73";

}


// 48 Lesson

//Drag and drop from the options below to add a new <li> element to the unordered list with id="list".

var el = document.createElement("li");


var txt = document.createTextNode("B");


el.appendChild(txt);


var ul = document.getElementById("list");


ul.appendChild(el);

//Drag and drop from the options below to remove the node element from the page (par is node's parent).

var par = document.getElementById("par");

var node = document.getElementById("node");

par.removeChild(node);

//Which method is used to replace nodes?

//replaceChild

// 49 Lesson

//To create an animation relative to a container, the position attribute for the container should be set to:

//relative

/*
What is the interval for this timer?
var t = setInterval(func, 10000);
*/

//10 seconds

//Which function is used to stop a setInterval timer?

//clearInterval

// 50 Lesson

//The type of function that executes when an event occurs is called:

//event handler

//Fill in the blanks to call func() when the button is clicked.

<button onclick="func()">

  Click Here

</button>

//Drag and drop from the options below to call the clear() function after body is loaded.

<body onload="clear()">

</body>

//Can multiple event handlers be added to a single element?

//Yes

// 51 Lesson

//A paragraph is inside a div element. You want the paragraph’s click event to be handled first. You should use:

//Bubbling

//Drag and drop from the options below to handle the click event and use capturing propagation.

x.addEventListener("click", func, true);

// 52 Lesson

//Fill in the blanks to define an array.

var arr = ['A', 'B', 'C'];

/*
What will be the content of the paragraph after the user clicks on it twice?
<p id='txt' onclick='test();'>20</p>
<script>
function test() {
  var x=document.getElementById('txt');
  var n = x.innerHTML;
  x.innerHTML = n/2;
}
</script>
*/

//5

// 53 Lesson

//The form will submit to its action if onsubmit returns:

//true

// 54 Lesson

//Fill in the blanks to change the content of all paragraph tags of the page to "SoloLearn".

var arr = document.

  getElementsByTagName("p");

for(var x=0; x<arr.length; x++) 

{

   arr[x].innerHTML="SoloLearn";

}

/*
What is the output of this code?
<div id="test">
<p>some text</p>
</div>
<script>
var el=document.getElementById("test");
alert(el.hasChildNodes());
</script>
*/

//true

//Drag and drop from the options below to change the color of the paragraph with id="p2" to red.

<script>


var d = document.


    getElementById("p2");

d.style.color="red";


</script>

//Can you handle multiple events on the same HTML element?

//Yes

//Fill in the blanks to alert a message when the button is clicked.

<button onclick="msg()">Click me</button>

<script>

function msg() {

  alert("Hi!");

}

</script>

//Display an alert when the mouse pointer is over the div tag:

<div onmouseover="alert('Hi!');">

  put the mouse pointer over me

</div>