type Parent = {
    firstName: string
    middleName: string
    lastName: string
    email: string
    educationQualification: string
    profession: string
    designation: string
    phone: number
  }
  
  type Address = {
    city: string
    state: string
    country: string
    pin: number
  }
  
  type Emergency = {
    relation: string
    phone: number
  }
  
  export interface Student {
    firstname: string
    middlename: string
    lastname: string
    dateofbirth: Date
    placeofbirth: string
    firstlanguage: string
    address: Address
    father: Parent
    mother: Parent
    emergency: Emergency[]
  }
