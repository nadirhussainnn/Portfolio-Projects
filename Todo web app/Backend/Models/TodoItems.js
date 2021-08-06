
const mongoose=require('mongoose')

const ItemsSchema=new mongoose.Schema({
    itemDescription:{
        type: String,
        required: true
    }
}, {timestamps: true})

//Create model and name it, give created schema and export
const Item=mongoose.model('Item', ItemsSchema)

module.exports=Item