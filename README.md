# Face Protect
### Facial Offline Protection - Security is Priority

### Microsoft Engage 2022 - Face Recognition

![image](https://drive.google.com/uc?export=view&id=1S1bqQV0677aF6qEKHaJng398D4TD1m25)


#### About:
We could use a ton of security on our smartphones like biometric authentication using **Face** and **Fingerprint** recognition.
But our **desktops** and **laptops** have lagged behind. So, here we
need Face Protect a facial authenticator to protect our apps & data on our Desktops & Laptops, and the best part is, it works *offline*.

<br/>


#### How to Run / Execute the Application from .exe
- Go to *bin/Debug* -> run **MYFACE.exe** 

<br/>

#### Face Protect demo - [learn how to use this app](https://www.youtube.com/watch?v=lmMq4UMkEc8)   

[![Face Protect Demo](https://img.youtube.com/vi/lmMq4UMkEc8/0.jpg)](https://www.youtube.com/watch?v=lmMq4UMkEc8)  

- Turn ON Closed Captions!   
- Description of video will add value as well 😄  
   
<br/>



### How to use this project:

#### Prerequisites
- Microsoft Visual Studio
- .Net Framework 4.6.1

#### Steps to Run
1. Clone this repo to your local storage.
2. Go to Microsoft Visual Studio
   File Menu -> Open -> Project/Solution
   Select " **MYFACE.sln** " file in the cloned project.

   or

   You can simply double click on " **MYFACE.sln** " to launch Microsoft Visual Studio and this project will load.
3. Now you can explore the code on right side by selecting files from "*Solution Explorer*" window.
4. Click the "*Start*" button on top of code, in the Quick Access Menu Bar to run this project.

<br/>


**Tech Stack :** C#, Windows Form  
**IDE :** Microsoft Visual Studio , .Net Framework 4.6.1  
**Library for Face Recognition :** Emgu CV - OpenCV wrapper for C#  

<br/>

**Troubleshoot :**  
Packages are already included with this project.  
- EmguCV v3.1.0.1  
- FaceRecognition.dll  
- Haarcascade 

If you get errors related to EmguCV you could download it through **NuGet Package Manager** by right clicking on 
*References* in *Solution Explorer* window and select *NuGet Package Manager* the click on *Browse Tab*, search for *EmguCV* and *Install*.   
<br/>
If you get errors related to *FacRec* or *FaceRec_Location* functions you can add reference to FaceRecognition.dll through "*Reference*" option in *Solution Explorer* window and right click, *Add Reference* option, now Reference Manager window will pop up, *browse* to *bin/Debug* and double click *FaceRecognition.dll* then press *OK*.  
<br/>
Haarcascade folder is in *bin/Debug* which contains a pre-trained face detection model which helps in detecting face.   
