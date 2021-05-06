<html>
    <head>
       

    <style>
    body{background-color: #ffe9d6;
    color: rgb (255,255,255);
    display: flex ; 
    flex-direction: column;
    align-items:center;
    justify-content:center;
    margin-top: 60px;
    }
        div{
    height:90px;
    width: 100px;
    margin-top: auto;
    color: white;
     background-color: #02475e;
        }
  .glow {
    box-shadow:

}
    </style>
    </head>
        <body>
<table>
    <caption> <b>Game 6x6</b> </caption>
    <tr>
           <td>
            <div id="1" style="background-color: #e28f83; font-color :black">Start here!</div>
           </td> 
           <td>
            <div id="2"></div>
           </td> 
           <td>
            <div id="3"></div>
           </td>
           <td>
            <div id="4"></div>
           </td>
           <td>
            <div id="5"></div>
           </td>
           <td>
            <div id="6"></div>
           </td>
    </tr>
    <tr>
        <td>
         <div id="7"></div>
        </td> 
        <td>
         <div id="8" ></div>
        </td> 
        <td>
         <div id="9"></div>
        </td>
        <td>
        <div id="10"></div>
    </td>
    <td>
     <div id="11"></div>
    </td>
    <td>
     <div id="12"></div>
    </td>
 </tr>
 <tr>
    <td>
     <div id="13"></div>
    </td> 
    <td>
     <div id="14" ></div>
    </td> 
    <td>
     <div id="15"></div>
    </td>
    <td>
    <div id="16"></div>
</td>
<td>
 <div id="17"></div>
</td>
<td>
 <div id="18"></div>
</td>
</tr>
<tr>
    <td>
     <div id="19"></div>
    </td> 
    <td>
     <div id="20"></div>
    </td> 
    <td>
     <div id="21"></div>
    </td>
    <td>
    <div id="22"></div>
</td>
<td>
 <div id="23"></div>
</td>
<td>
 <div id="24"></div>
</td>
</tr>
<tr>
    <td>
     <div id="25"></div>
    </td> 
    <td>
     <div id="26"></div>
    </td> 
    <td>
     <div id="27" ></div>
    </td>
    <td>
    <div id="28"></div>
</td>
<td>
 <div id="29"></div>
</td>
<td>
 <div id="30"></div>
</td>
</tr>
<tr>
    <td>
     <div id="31"></div>
    </td> 
    <td>
     <div id="32"></div>
    </td> 
    <td>
     <div id="33"></div>
    </td>
    <td>
    <div id="34" ></div>
</td>
<td>
 <div id="35"></div>
</td>
<td>
 <div id="d36" style="background-color:#81b214;" class="glow">Goal </div>
</td>
</tr>


</table>


<script>
let win = document.getElementById("d36");
let divs = document.getElementsByTagName("div");
let random1= Math.floor(Math.random()*4)

for (let i = 0 ;i <=divs.length; i++)
    {  let random2 = Math.floor(Math.random() *6);
        if(random1 != random2 && random1 != random2 -1 && random1 != random2 +1 && random1 != 1 && random1 != 36 && random2 != 1 && random2 != 36 ){
            divs[i].style.backgroundColor= "#595a57";
             }
           divs[i].onclick = function(e){
           
            

         
             divs[i].style.backgroundColor= "#e28f83";
          
         

          }
        
        win.onclick = function(e){
            alert("You Win !");
         win.style.boxShadow = "0 0 90px 90px #e28f83";
 
      

       }
    }

    

</script>
</body>
</html>
