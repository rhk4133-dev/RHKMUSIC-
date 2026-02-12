const songs=[
    {name:"KAGADADA DONIYALLI",file:"song1.mp3",img:"img1.jpg"},
    {name:"KANAVE KANAVE",file:"song2.mp3",img:"img2.jpg"},
    {name:"ZARA ZARA",file:"song3.mp3",img:"img3.jpg"},
    {name:"DIL LAGANA",file:"song4.mp3",img:"img4.jpg"},
    {name:"ENGLISH SONG",file:"song5.mp3",img:"img5.jpg"}
];

const audio=document.getElementById("audio");
const songGrid=document.getElementById("songGrid");
const bottomImg=document.getElementById("bottomImg");
const bottomTitle=document.getElementById("bottomTitle");
const playBtn=document.getElementById("playBtn");
const progress=document.getElementById("progress");

let current=0;
let playing=false;

/* Load Songs Grid */
songs.forEach((song,index)=>{
    const div=document.createElement("div");
    div.classList.add("song-card");
    div.innerHTML=`
        <img src="${song.img}">
        <h4>${song.name}</h4>
    `;
    div.onclick=()=>loadSong(index);
    songGrid.appendChild(div);
});

function loadSong(i){
    current=i;
    audio.src=songs[i].file;
    bottomImg.src=songs[i].img;
    bottomTitle.innerText=songs[i].name;
    play();
}

function play(){
    audio.play();
    bottomImg.style.animationPlayState="running";
    playBtn.innerText="⏸";
    playing=true;
}

function toggle(){
    if(!audio.src){
        loadSong(0);
        return;
    }

    if(playing){
        audio.pause();
        bottomImg.style.animationPlayState="paused";
        playBtn.innerText="▶";
    }else{
        play();
    }
    playing=!playing;
}

function next(){
    current=(current+1)%songs.length;
    loadSong(current);
}

function prev(){
    current=(current-1+songs.length)%songs.length;
    loadSong(current);
}

/* Progress */
audio.addEventListener("timeupdate",()=>{
    if(audio.duration){
        progress.style.width=(audio.currentTime/audio.duration)*100+"%";
    }
});

function seek(e){
    const width=e.currentTarget.clientWidth;
    audio.currentTime=(e.offsetX/width)*audio.duration;
}