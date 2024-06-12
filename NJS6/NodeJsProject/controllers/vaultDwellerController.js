const VaultDweller = require('../models/vault_dweller');

module.exports = {
    register (req, res){
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.create(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'Fallo la creacion del morador',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    getDweller(req, res)
    {
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.getDweller(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'aqui toy',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    getAllDwellers(req, res)
    {
        const vault_dweller = req.body; //La captura de datos del morador
        VaultDweller.getAllDwellers(vault_dweller, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'aqui toy',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    Datos(req, res) {
        const datos = req.body; // La captura de datos del morador
        VaultDweller.updateDatos(datos, (err, data) => {
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'Fallo la creacion de datos',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    },

    DatosCambio(req,res){
        const datos = req.body;
        VaultDweller.setDatos(datos, (err,data) => {
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'Fallo el cambio de datos',
                    error : err
                })
            }
            return res.status(201).json({
              success : true,
              message: 'Todo funciono',
              data : data
            });
        });
    },
    
    getDatos(req, res)
    {
        const datos = req.body; 
        VaultDweller.getDatos(datos, (err, data)=>{
            if (err){
                return res.status(501).json({
                    success: false,
                    message: 'no se encontro informacion',
                    error: err
                })
            }

            return res.status(201).json({
                succses: true,
                message: 'todo salio bien',
                data: data
            });
        });
    }
}
