body{
    margin:0;
    font-family:Arial;
    background:#0f0f0f;
    color:white;
}

/* LOGIN */
.login-body{
    display:flex;
    justify-content:center;
    align-items:center;
    height:100vh;
    background:linear-gradient(45deg,#0f0,#00f);
}

.login-box{
    background:rgba(255,255,255,0.1);
    backdrop-filter:blur(15px);
    padding:40px;
    border-radius:20px;
    text-align:center;
}

.login-box input{
    display:block;
    margin:15px 0;
    padding:10px;
    width:200px;
}

/* MAIN LAYOUT */
.main{
    display:flex;
}

.sidebar{
    width:200px;
    background:#111;
    padding:20px;
}

.sidebar p{
    margin:15px 0;
    cursor:pointer;
}

/* GLASS CARD */
.content{
    flex:1;
    display:flex;
    justify-content:center;
    align-items:center;
    height:100vh;
}

.glass-card{
    background:rgba(255,255,255,0.1);
    backdrop-filter:blur(20px);
    padding:40px;
    border-radius:20px;
    text-align:center;
    box-shadow:0 0 30px #0f0;
}

.glass-card img{
    width:200px;
    border-radius:20px;
    animation:spin 6s linear infinite;
    animation-play-state:paused;
}

@keyframes spin{
    100%{transform:rotate(360deg);}
}

.controls button{
    margin:10px;
    padding:10px 20px;
    background:#0f0;
    border:none;
    border-radius:10px;
    cursor:pointer;
}

/* EQUALIZER */
.equalizer{
    display:flex;
    justify-content:center;
    margin:15px 0;
}

.equalizer span{
    width:5px;
    height:20px;
    background:#0f0;
    margin:0 3px;
    animation:wave 1s infinite ease-in-out;
}

.equalizer span:nth-child(2){animation-delay:0.2s;}
.equalizer span:nth-child(3){animation-delay:0.4s;}
.equalizer span:nth-child(4){animation-delay:0.6s;}
.equalizer span:nth-child(5){animation-delay:0.8s;}

@keyframes wave{
    0%,100%{height:20px;}
    50%{height:60px;}
}
