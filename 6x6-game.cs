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
            <div id="1" style="background-color: #e28f83;">1</div>
           </td> 
           <td>
            <div id="2">2</div>
           </td> 
           <td>
            <div id="3">3</div>
           </td>
           <td>
            <div id="4">4</div>
           </td>
           <td>
            <div id="5">5</div>
           </td>
           <td>
            <div id="6">6</div>
           </td>
    </tr>
    <tr>
        <td>
         <div id="7">7</div>
        </td> 
        <td>
         <div id="8" >8</div>
        </td> 
        <td>
         <div id="9">9</div>
        </td>
        <td>
        <div id="10">10</div>
    </td>
    <td>
     <div id="11">11</div>
    </td>
    <td>
     <div id="12">12</div>
    </td>
 </tr>
 <tr>
    <td>
     <div id="13">13</div>
    </td> 
    <td>
     <div id="14" >14</div>
    </td> 
    <td>
     <div id="15">15</div>
    </td>
    <td>
    <div id="16">16</div>
</td>
<td>
 <div id="17">17</div>
</td>
<td>
 <div id="18">18</div>
</td>
</tr>
<tr>
    <td>
     <div id="19">19</div>
    </td> 
    <td>
     <div id="20">20</div>
    </td> 
    <td>
     <div id="21">21</div>
    </td>
    <td>
    <div id="22">22</div>
</td>
<td>
 <div id="23">23</div>
</td>
<td>
 <div id="24">24</div>
</td>
</tr>
<tr>
    <td>
     <div id="25">25</div>
    </td> 
    <td>
     <div id="26">26</div>
    </td> 
    <td>
     <div id="27" >27</div>
    </td>
    <td>
    <div id="28">28</div>
</td>
<td>
 <div id="29">29</div>
</td>
<td>
 <div id="30">30</div>
</td>
</tr>
<tr>
    <td>
     <div id="31">31</div>
    </td> 
    <td>
     <div id="32">32</div>
    </td> 
    <td>
     <div id="33">33</div>
    </td>
    <td>
    <div id="34" >34</div>
</td>
<td>
 <div id="35">35</div>
</td>
<td>
 <div id="d36" style="background-color:#81b214;" class="glow">36</div>
</td>
</tr>


</table>


<script>
let win = document.getElementById("d36");
let divs = document.getElementsByTagName("div");
let random1= Math.floor(Math.random()*4)

for (let i = 0 ;i <=divs.length; i++)
    {  let random2 = Math.floor(Math.random() *2);
        if(random1 != random2 && random1 != random2 -1 && random1 != random2 +1 && random1 != 1 && random1 != 36 && random2 != 1 && random2 != 36 ){
            divs[i].style.backgroundColor= "#595a57";
             }
           divs[i].onclick = function(e){
           
            

         
             divs[i].style.backgroundColor= "#e28f83";
          
         

          }
        
        win.onclick = function(e){
            alert("You Win !");
         win.style.boxShadow = "0 0 90px 90px #e28f83";
 
      

       }}

    

</script>
</body>
</html>
