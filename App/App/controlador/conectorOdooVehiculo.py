import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069/xmlrpc/'
DB='net'
USER='gbonanno@uoc.edu'
PASS='admin'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/Flota/python/vehiculos.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_vehiculo','create',[{
            'x_idVehiculo':subraiz[0].text,
            'x_marca':subraiz[1].text,
            'x_tipoVehiculo':subraiz[2].text,
            'x_disponibilidadVehiculo':subraiz[3].text,
            'x_volumenGasolina':subraiz[4].text,
            'x_estado':subraiz[5].text,
            }])
    print('Vehiculos Cargados correctamente')
else:
    print('Error al conectar a Odoo')