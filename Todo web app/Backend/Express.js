
const express=require('express')
const cors=require('cors')
const mongoose=require('mongoose')
const app=express()

const ItemModel=require('./Models/TodoItems')
const PORT=5000


const mongoDb='YOUR_MONGODB_URL'

app.use(cors())
//app.use(express.urlencoded({extended: true}))     //To parse x-www-form-urlencoded data: from postman
app.use(express.json())                             //To parse form data

mongoose.connect(mongoDb, /*We place this to remove warning*/{ useNewUrlParser: true, useUnifiedTopology: true  }).then(()=>{
    console.log("Connected to MongoDB database")
}).catch(()=>{console.log("Error")})

//Add item
app.post('/addItem' , (req , res)=>{

    const desc=req.body.desc
    const todo=new ItemModel({
        itemDescription: desc
    })
    todo.save().then(result=>res.send("Added Item Successfully")).catch(err=>res.send("Error occured"))
})

//Update Item
app.put('/update/:itemId' , (req , res)=>{

    const itemId=req.params.itemId
    const desc=req.body.desc
    ItemModel.findByIdAndUpdate(itemId, {itemDescription: desc}).then(result=>res.send("1")).catch(err=>res.send("0"))
   
})

//Delete item
app.delete('/deleteItem/:itemId' , (req , res)=>{  
    
    const del=req.params.itemId
    ItemModel.findByIdAndDelete(del).then(result=>res.send("1")).catch(result=>res.send("0"))
})

//Get All/one Item(s)

app.get('/getItems' , (req , res)=>{
    ItemModel.find().then(result=>res.send(result)).catch(error=>res.send(error))
    //ItemModel.findById('60f9c1c26631be295858176d').then(result=>res.send(result)).catch(error=>res.send(error))
})

app.listen(PORT,()=>{
    console.log(`Server Running on ${PORT} port `)
})