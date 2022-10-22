// 1 Lesson

//Go was designed at:

//Google

//Drag and drop to result in the output "Learning Go!".

package main

import "fmt"

func main() {

   fmt.Println("Learning Go!")

}


// 2 Lesson

//Which package is used when you run a Go program?

//main

//Fill in the blanks to import the math package:

import "math"


// 3 Lesson

Create a program that outputs "Go is awesome" to the screen.

package main


import "fmt"

func main() {


fmt.Println("Go is awesome")

}

//Rearrange the code to create a valid Go program that outputs "Hi" to the screen.

package main

import "fmt"

func main(){

  fmt.Println("Hi")
  }

// 4 Lesson

//Fill in the blank to create a valid comment.

// output is a number

fmt.Println(42)

//Rearrange the code to create a valid comment.

/*
some comment
*/

// 5 Lesson

//Fill in the blanks to create a valid program that outputs "Go".

package main

import "fmt"



func main() {

  fmt.Println("Go")

}

/*
How many lines will the following code output?

package main
import "fmt"
func main() {
  /* fmt.Println("1") */
  fmt.Println("2")
  //fmt.Println("3")
}
*/

//1

//Fill in the blanks to import the "fmt" and "math" packages.

import (

  "fmt"

  "math"

)

//Exported names from packages should:

//start with a capital letter

// 6 Lesson

/*
Debug & Fix


Your colleague tried to make a program that is intended to output "GO" three times on separate lines.
However, he is still new to Go and has made a number of mistakes in the code.

Debug and fix the code to produce the desired output.
*/

package main
import "fmt"

func main() {
   // outputs GO 3 times
    fmt.Println("GO")
    fmt.Println("GO")
    fmt.Println("GO")
}