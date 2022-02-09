let notification = document.querySelector(".notification"),
avatar =document.querySelector(".avtar");

dropMenu(notification);
dropMenu2(avatar);

function dropMenu (sellctore){
    sellctore.addEventListener("click",()=>{
        let dropdownMenu =document.querySelector(".dropdown-menu")
        dropdownMenu.classList.contains("active") ?  dropdownMenu.classList.remove("active") : dropdownMenu.classList.add("active");

    })
}
function dropMenu2 (sellctore){
    sellctore.addEventListener("click",()=>{
        let dropdownMenu2 =document.querySelector(".dropdown-menu.setting");
        dropdownMenu2.classList.contains("active") ?  dropdownMenu2.classList.remove("active") : dropdownMenu2.classList.add("active");

    })
}

//SideBar Toggle
let sideBar =document.querySelector(".sidebar"),
bars = document.querySelector(".bars");
bars.addEventListener("click",()=>{
    if(sideBar.classList.contains("active"))
    {
      sideBar.classList.remove("active");
      sideBar.style.width='80px';
    }
    else{
      sideBar.classList.add("active");
      sideBar.style.width='250px';
      sideBar.style. transition='.5s width ease-in-out';
    }
})

//sidebarNave toggle color
let sidebarNave =Array.from( document.querySelectorAll(".sidebar-nav"));

sidebarNave.forEach(e=>{

  e.addEventListener("click",()=>{
    
    sidebarNave.forEach(w=>{
      w.classList.remove('active');
    })
 
    e.classList.add("active");
    //e.classList.contains("active") ?  e.classList.remove("active") : e.classList.add("active");

  })
})


let Visitors =[800,320,190,250,400,600],
    Hired = [502 ,203,70,200,350,400]
    Years =[2015,2016,2017,2018,2019,2020];
///chart
var options = {
    chart: {
      type: 'area',
      height:'100%',
      width:'100%'

    },
    series: [{
      type: 'area',
      name:"Visitors",
      data: Visitors
    }, {
      type: 'area',
      name:"Hired",
      data: Hired

    }],
    xaxis: {
      categories: [...Years]
    },
    colors:['#43a047','#e65245','#e43a15']
  }
  
  var chart = new ApexCharts(document.querySelector("#chart"), options);
  
  chart.render();
  

  //Toggle Mode
   let mode =document.querySelector(".mode");

   mode.addEventListener("click",()=>{
     if(document.body.classList.contains("dark"))
     {
     document.body.classList.remove("dark");
     mode.querySelector("i").classList.replace("fa-sun","fa-moon")

     }
     else{
      document.body.classList.add("dark");
      mode.querySelector("i").classList.replace("fa-moon","fa-sun")
    }
   })


   //
   Window.machMedia("(max-width)").matches ? sideBar.classList.remove("active")
   : sideBar.classList.add("active");